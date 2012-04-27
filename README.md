TestFlightUnity
===============

a TINY library to integrate the TestFight SDK to any Unity 3D (iOS) project 

How to Setup
============

1. Sync it to your Unity project folder, make sure the source files (TestFlight\*\.\*) are put in Assets/Plugins/iOS
2. Get the TestFlight SDK from official website. Put TestFlight.h & libTestFlight.a under the same folder.
3. That's it!

How to Use
==========

Currently, these functions are now available in Unity:

TestFlightUnity.TakeOff("\<your TestFlight token\>");       // Start the TestFlight. Call it once when your game starts

TestFlightUnity.PassCheckpoint("\<checkpoint name\>");      // Log a checkpoint, which you could view later on TestFlight website

All the TestFlight functionality will be automatically integrated and activated after you build the project for iOS platform. No extra step is needed now!

Links
=====

TestFlight: http://testflightapp.com/

My blog: http://whenitsdone.org/
