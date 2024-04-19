#stop all virtual machines

# Login to your Azure account
Connect-AzAccount

# Set your subscription
Set-AzContext -Subscription "your-subscription-id"

# Get all virtual machines
$vms = Get-AzVM

# Stop each virtual machine
foreach ($vm in $vms)
{
    Stop-AzVM -ResourceGroupName $vm.ResourceGroupName -Name $vm.Name -Force
}