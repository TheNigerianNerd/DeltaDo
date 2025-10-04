# DeltaDo

**DeltaDo** is an offline-first Blazor WebAssembly **PWA** Todo app by *The Nigerian Nerd*.  
It stores data locally (IndexedDB/JSON) and syncs **deltas** (changes) to a cloud API when online.

## Tech
- C# 12 / .NET 8 / Blazor WASM (PWA)
- Local: IndexedDB (JSON cache)
- Server (next step): .NET 8 Minimal API + PostgreSQL
- Tooling: Git, Docker, GitHub Actions, AWS/Azure target

## Goals
- Offline-first UX
- Delta-based sync + conflict resolution
- Reproducible builds & deployments
