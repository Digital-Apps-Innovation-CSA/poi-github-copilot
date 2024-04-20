#create a vm whit all components and bastion configuration

# Login to your Azure account
Connect-AzAccount

# Set your subscription
Set-AzContext -Subscription "your-subscription-id"

# Create a new resource group
New-AzResourceGroup -Name "rvrrgrouppipe" -Location "West US"

# Create a new virtual network
$vnet = New-AzVirtualNetwork -ResourceGroupName "rvrrgrouppipe" -Location "West US" -Name "myVNet" -AddressPrefix "10.0.0.0/16"

# Create a new subnet for the virtual network
$subnet = Add-AzVirtualNetworkSubnetConfig -Name "mySubnet" -AddressPrefix "10.0.0.0/24" -VirtualNetwork $vnet

# Create a new public IP address
$pip = New-AzPublicIpAddress -ResourceGroupName "rvrrgrouppipe" -Location "West US" -Name "myPublicIP" -AllocationMethod Dynamic

# Create a new network security group
$nsg = New-AzNetworkSecurityGroup -ResourceGroupName "rvrrgrouppipe" -Location "West US" -Name "myNSG"

# Create a new network interface
$nic = New-AzNetworkInterface -Name "myNic" -ResourceGroupName "rvrrgrouppipe" -Location "West US" -SubnetId $subnet.Id -PublicIpAddressId $pip.Id -NetworkSecurityGroupId $nsg.Id

# Create a new virtual machine
New-AzVm -ResourceGroupName "rvrrgrouppipe" -Location "West US" -Name "vmrvrbase001" -NetworkInterfaceId $nic.Id -Image "MicrosoftWindowsServer:WindowsServer:2016-Datacenter:latest" -Size "Standard_D2s_v3" -Credential (Get-Credential)

# Create a new public IP address for the Bastion host
$bastionPip = New-AzPublicIpAddress -ResourceGroupName "rvrrgrouppipe" -Location "West US" -Name "rvrbation123PublicIP" -AllocationMethod Static -Sku Standard

# Create a new subnet for the Bastion host
$bastionSubnet = Add-AzVirtualNetworkSubnetConfig -Name "AzureBastionSubnet" -AddressPrefix "10.0.1.0/27" -VirtualNetwork $vnet

# Create a new Bastion host
New-AzBastion -ResourceGroupName "rvrrgrouppipe" -Name "rvrbation123" -PublicIpAddress $bastionPip -VirtualNetwork $vnet -Location "West US"