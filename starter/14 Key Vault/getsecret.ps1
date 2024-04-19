# get secret from key vault

# Login to your Azure account
Connect-AzAccount

# Set your subscription
Set-AzContext -Subscription "your-subscription-id"

# Get the secret
$secret = Get-AzKeyVaultSecret -VaultName "myKeyVault" -Name "mySecret"

# Print the secret value
$secret.SecretValueText