# Create a new resource group

# Login to your Azure account
Connect-AzAccount

# Set your subscription
Set-AzContext -Subscription "your-subscription-id"

# Create a new resource group
New-AzResourceGroup -Name "myResourceGroup" -Location "West US"