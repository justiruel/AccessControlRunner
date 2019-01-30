## Apa itu AccessControlRunner?
- sebuah aplikasi sederhana untuk run web API access control ("dotnet VDI.Demo.Web.Host.dll"), untuk selanjutnya file *.exe nya dipakai untuk window service agar web API-nya selalu jalan tanpa menggunakan IIS dan dapat dijadikan sebagai windows service

## How to use?
- jalankan => dotnet publish -c Release -r win10-x64 (pilihan publish OS => https://docs.microsoft.com/en-us/dotnet/core/rid-catalog)
- copy data dari \AccessControlRunner\AccessControlRunner\bin\Release\netcoreapp2.1\win10-x64 ke publish-an web API (AccessControlNetCore)
- Jalankan AccessControlRunner.exe
- Web API dapat dibuka tanpa IIS