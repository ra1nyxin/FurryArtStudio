$assemblyInfo = Get-Content ".\My Project\AssemblyInfo.vb"

$versionLine = $assemblyInfo | Where-Object { $_ -match "AssemblyVersion" }

if ($versionLine -match '"(\d+\.\d+\.\d+)\.\d+"') {
    $version = $matches[1]
}

Write-Host "Detected version: $version"

$tagName = "v$version"

# 更新 CHANGELOG
$whatsNew = Get-Content .\WHATSNEW.txt -Raw
$changelog = ""

if (Test-Path .\CHANGELOG.txt) {
    $changelog = Get-Content .\CHANGELOG.txt -Raw
}

$newContent = $whatsNew.TrimEnd() + "`r`n`r`n" + $changelog.TrimStart()
Set-Content .\CHANGELOG.txt $newContent -Encoding UTF8

Write-Host "CHANGELOG updated."

# 提交
git add CHANGELOG.txt
git commit -m "Version $tagName"

# 创建 tag
git tag $tagName

# 推送
git push
git push origin $tagName

Write-Host "Release $tagName pushed successfully."