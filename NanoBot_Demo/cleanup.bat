REM
REM Keenan's Hack to remove intermediate files
REM If you find a way to enhance, please return updates to
REM ekeenan2@cdm.depaul.edu
REM
REM This is Nathan Andre's Version for Unity using Visual Studio

REM cleanup root director

    rmdir /S /Q .vs
    rmdir /S /Q Temp
    rmdir /S /Q Library


    del /F *.csproj
    del /F *.sln
    del /F *.db
  
REM Delete All Folders in Library

REM cd Library
REM For  /D  %%G in (*) do (

  REM Echo "%%G"
   REM rmdir /S /Q %%G)

REM For %%G in (*) do (
  REM IF "%%G" NEQ "AssetServerCacheV3"  del /F %%G
REM)
