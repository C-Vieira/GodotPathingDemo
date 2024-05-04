cmake_minimum_required(VERSION 3.27)
project(src)

set(CMAKE_CXX_STANDARD 14)

include_directories(.)

add_executable(src
        gdexample.cpp
        gdexample.h
        register_types.cpp
        register_types.h)
