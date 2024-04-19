#create a blob storage

# Login to your Azure account
Connect-AzAccount

# Set your subscription
Set-AzContext -Subscription "your-subscription-id"

# Create a new storage account
$storageAccount = New-AzStorageAccount -ResourceGroupName "myResourceGroup" -Name "myStorageAccount" -Location "West US" -SkuName Standard_LRS

# Get the storage account key
$key = (Get-AzStorageAccountKey -ResourceGroupName "myResourceGroup" -Name "myStorageAccount").Value[0]

# Create a context for the storage account
$context = New-AzStorageContext -StorageAccountName "myStorageAccount" -StorageAccountKey $key

# Create a new blob container
New-AzStorageContainer -Name "myContainer" -Context $context