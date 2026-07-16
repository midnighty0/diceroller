#!/bin/bash
echo "Compiling DiceRoller..."
dotnet publish -c Release --use-current-runtime -p:PublishSingleFile=true -o ./build_output
echo "Installing to ~/.programs/diceroller/bin..."
mkdir -p ~/.programs/diceroller/bin
mv ./build_output/DiceRoller ~/.programs/diceroller/bin/diceroller
rm -rf ./build_output
