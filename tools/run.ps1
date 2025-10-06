$root   = Split-Path -Parent $PSScriptRoot
$data   = Join-Path $root "data\todos.json"
$target = Join-Path $root "src\DeltaDo.Client\wwwroot\DeltaDo.Shared\data"

New-Item -ItemType Directory -Force -Path $target | Out-Null
Copy-Item $data (Join-Path $target "todos.json") -Force

Set-Location (Join-Path $root "src\DeltaDo.Client")
dotnet watch run
