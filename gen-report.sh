#! /bin/bash

reportgenerator -reports:"./XUnit.Coverlet.MSBuild/coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
