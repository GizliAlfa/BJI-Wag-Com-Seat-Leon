# BJI VCDS Helper - Build Script
# 2016 Seat Leon Style Paket

Write-Host "========================================" -ForegroundColor Cyan
Write-Host "  BJI VCDS Helper - Build Script" -ForegroundColor Yellow
Write-Host "  2016 Seat Leon Style Paket" -ForegroundColor Green
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

$ProjectPath = "VcdsHelper.csproj"
$OutputDir = "bin\Release\net8.0\win-x64\publish"
$ExeName = "VcdsHelper.exe"

# .NET SDK kontrolü
Write-Host "1. .NET SDK kontrolü yapılıyor..." -ForegroundColor Yellow
try {
    $dotnetVersion = dotnet --version
    Write-Host "   ✓ .NET SDK bulundu: $dotnetVersion" -ForegroundColor Green
} catch {
    Write-Host "   ✗ .NET SDK bulunamadı!" -ForegroundColor Red
    Write-Host "   Lütfen .NET 8.0 SDK'yı yükleyin: https://dotnet.microsoft.com/download" -ForegroundColor Yellow
    exit 1
}

Write-Host ""

# Temizlik
Write-Host "2. Eski build dosyaları temizleniyor..." -ForegroundColor Yellow
if (Test-Path "bin") {
    Remove-Item -Path "bin" -Recurse -Force
    Write-Host "   ✓ bin klasörü temizlendi" -ForegroundColor Green
}
if (Test-Path "obj") {
    Remove-Item -Path "obj" -Recurse -Force
    Write-Host "   ✓ obj klasörü temizlendi" -ForegroundColor Green
}

Write-Host ""

# NuGet paketlerini geri yükle
Write-Host "3. NuGet paketleri geri yükleniyor..." -ForegroundColor Yellow
dotnet restore $ProjectPath
if ($LASTEXITCODE -eq 0) {
    Write-Host "   ✓ NuGet paketleri başarıyla yüklendi" -ForegroundColor Green
} else {
    Write-Host "   ✗ NuGet paketleri yüklenirken hata oluştu!" -ForegroundColor Red
    exit 1
}

Write-Host ""

# Build
Write-Host "4. Proje derleniyor..." -ForegroundColor Yellow
dotnet build $ProjectPath -c Release
if ($LASTEXITCODE -eq 0) {
    Write-Host "   ✓ Proje başarıyla derlendi" -ForegroundColor Green
} else {
    Write-Host "   ✗ Derleme hatası!" -ForegroundColor Red
    exit 1
}

Write-Host ""

# Publish (Tek dosya EXE)
Write-Host "5. EXE dosyası oluşturuluyor..." -ForegroundColor Yellow
Write-Host "   (Bu işlem birkaç dakika sürebilir...)" -ForegroundColor Gray

dotnet publish $ProjectPath `
    -c Release `
    -r win-x64 `
    --self-contained true `
    -p:PublishSingleFile=true `
    -p:EnableCompressionInSingleFile=true `
    -p:DebugType=None `
    -p:DebugSymbols=false

if ($LASTEXITCODE -eq 0) {
    Write-Host "   ✓ EXE dosyası başarıyla oluşturuldu" -ForegroundColor Green
} else {
    Write-Host "   ✗ EXE oluşturulurken hata!" -ForegroundColor Red
    exit 1
}

Write-Host ""

# Sonuç
$ExePath = Join-Path $OutputDir $ExeName
if (Test-Path $ExePath) {
    $FileSize = (Get-Item $ExePath).Length / 1MB
    Write-Host "========================================" -ForegroundColor Cyan
    Write-Host "  BUILD BAŞARILI!" -ForegroundColor Green
    Write-Host "========================================" -ForegroundColor Cyan
    Write-Host ""
    Write-Host "EXE Konumu:" -ForegroundColor Yellow
    Write-Host "  $ExePath" -ForegroundColor White
    Write-Host ""
    Write-Host "Dosya Boyutu:" -ForegroundColor Yellow
    Write-Host "  $([math]::Round($FileSize, 2)) MB" -ForegroundColor White
    Write-Host ""
    Write-Host "Çalıştırmak için:" -ForegroundColor Yellow
    Write-Host "  cd $OutputDir" -ForegroundColor White
    Write-Host "  .\$ExeName" -ForegroundColor White
    Write-Host ""
    
    # Kopyalama seçeneği
    $CopyChoice = Read-Host "EXE dosyasını proje kök dizinine kopyalamak ister misiniz? (E/H)"
    if ($CopyChoice -eq "E" -or $CopyChoice -eq "e") {
        $DestPath = "..\..\$ExeName"
        Copy-Item -Path $ExePath -Destination $DestPath -Force
        Write-Host "   ✓ Dosya kopyalandı: $DestPath" -ForegroundColor Green
        
        # Data klasörünü de kopyala
        $DataSource = Join-Path $OutputDir "Data"
        $DataDest = "..\..\"
        if (Test-Path $DataSource) {
            Copy-Item -Path $DataSource -Destination $DataDest -Recurse -Force
            Write-Host "   ✓ Data klasörü kopyalandı" -ForegroundColor Green
        }
    }
    
    Write-Host ""
    Write-Host "========================================" -ForegroundColor Cyan
    
} else {
    Write-Host "✗ EXE dosyası bulunamadı!" -ForegroundColor Red
    exit 1
}
