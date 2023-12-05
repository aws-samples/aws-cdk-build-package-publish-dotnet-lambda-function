#!/bin/sh

cd ./apps/src/FunctionOne/
dotnet build
dotnet-lambda package --output-package /tmp/FunctionOne.zip
#cd ../../../apps/src/FunctionTwo/
#dotnet build
#dotnet-lambda package --output-package /tmp/FunctionTwo.zip
#cd ../../../apps/src/FunctionThree/
#dotnet build
#dotnet-lambda package --output-package /tmp/FunctionThree.zip

cd  ../../../infra
cdk deploy