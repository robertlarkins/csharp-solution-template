# To run this script you may get the following error:
# File:\some\path\RenameSolution.ps1 cannot be loaded because running scripts is disabled on this system.
# to resolve it run the script as
# PS C:\path\to\root> powershell -ExecutionPolicy Bypass -File RenameSolution.ps1
# If $NewName is not provided it will default to an empty string.

param (
    [string]$CurrentName='Company.Product.',
    [string]$NewName)

# Rename Directories that contain the old name to the new name
Write-Host "`n----------"
Write-Host "Renaming directories starting with '$CurrentName' to instead start with '$NewName'"
Write-Host "These are the renamed directories:"

Get-ChildItem -Directory -Recurse -Filter "$CurrentName*" |
    Rename-Item -NewName {$_.Name -replace $CurrentName, $NewName} -PassThru |
    Write-Host


# Rename Files that contain the old name to the new name
Write-Host "`n----------"
Write-Host "Renaming files starting with '$CurrentName' to instead start with '$NewName'"
Write-Host "These are the renamed files:"

Get-ChildItem -File -Recurse -Filter "$CurrentName*" |
    Rename-Item -NewName {$_.Name -replace $CurrentName, $NewName} -PassThru |
    Write-Host


# Update the contents of file that contain the old name
Write-Host "`n----------"
Write-Host "Replacing '$CurrentName' within files with '$NewName'"
Write-Host "These are the files with replaced values:"

$Files = Get-ChildItem -File -Recurse -Exclude RenameSolution.ps1 | Select-String $NewName -List | Select Path

ForEach ($File in $Files)
{
    Write-Host $File
    (Get-Content -Path $File -Raw) -replace $CurrentName, $NewName |
        Set-Content -NoNewLine -Path $File
}
