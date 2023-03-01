#! /bin/bash

cd XUnit.Coverlet.MSBuild && dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura && cd ..
