#!/bin/bash

OPEN_API_URL="${OPEN_API_URL:-"https://api-dev.l3vels.xyz/docs-json"}"
PACKAGE_VERSION=$PACKAGE_VERSION
COMMIT_NAME="${COMMIT_NAME:-"fix: api changes"}"

USERNAME="${USERNAME:-"Giga Chkhikvadze"}"
USER_EMAIL="${USER_EMAIL:-"giga.chkhikvadze@gmail.com"}"

# Set the OpenAPI Generator options
OUTPUT_DIR="$(pwd)"


# Generate the client or server code
npx @openapitools/openapi-generator-cli generate -i "$OPEN_API_URL" -o "$OUTPUT_DIR"

# Set Git user
git config user.name "$USERNAME"
git config user.email "$USER_EMAIL"

echo git diff-index --quiet HEAD --;
# Check if changes exist
if [[ -z $(git status --porcelain) ]]; then
    echo "No changes detected."
else
    echo "Changes are detected."
    # Add, commit, and push the changes
    git add .
    git commit -m "$COMMIT_NAME"
    git pull --rebase origin main
    git push origin HEAD

    # Update the version number and publish the updated package to npm
    npm version patch # This will automatically commit the changes and create a new version tag
    npm publish --access public --otp=$NPM_OTP_TOKEN
    git push --follow-tags # Push the changes and the new tag to the remote repository
fi


