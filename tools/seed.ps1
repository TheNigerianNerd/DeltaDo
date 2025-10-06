param([int]$Count = 5)

$items = 1..$Count | ForEach-Object {
  [pscustomobject]@{
    Id     = [guid]::NewGuid().ToString()
    Title  = "Task $_"
    IsDone = $false
  }
}

$root = Split-Path -Parent $PSScriptRoot
$dataPath = Join-Path $root "data\todos.json"

$items | ConvertTo-Json -Depth 5 | Set-Content -Encoding UTF8 $dataPath
Write-Host "🌱 Seeded $Count items to $dataPath"
