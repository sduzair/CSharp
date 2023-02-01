#!/usr/bin/env bash

# echo 'Hello World!'


# get direct subdirectories of current directory (not recursive)
subdirs=$(find . -maxdepth 1 -type d)

# loop through subdirectories
for dir in $subdirs
do
    (
        # print current directory
        echo "Current directory: $dir"
        # change to subdirectory
        cd "$dir" || exit

        # run "dotnet new gitignore"
        dotnet new gitignore
        
    )
done

