#!/bin/bash

dotnet build Alacrity.csproj --output ../Assets/Alacrity/AlacrityCore -c Release
mv ../Assets/Alacrity/AlacrityCore/Alacrity.exe ../Assets/Alacrity/AlacrityCore/Alacrity.mv
