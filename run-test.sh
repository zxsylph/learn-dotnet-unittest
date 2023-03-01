#! /bin/bash

cd XUnit.Coverlet.Collector && dotnet test --collect:"XPlat Code Coverage" && cd ..
