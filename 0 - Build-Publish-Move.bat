@echo off

dotnet restore

dotnet build --no-restore -c Release

move /Y Panosen.CodeDom.JavaScript\bin\Release\Panosen.CodeDom.JavaScript.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.CodeDom.JavaScript.Engine\bin\Release\Panosen.CodeDom.JavaScript.Engine.*.nupkg D:\LocalSavoryNuget\

pause