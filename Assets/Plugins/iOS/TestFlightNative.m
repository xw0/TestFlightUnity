#import "TestFlight.h"

void TestFlight_TakeOff(const char* token)
{
    [TestFlight takeOff:[NSString stringWithUTF8String:token]];
}

void TestFlight_PassCheckpoint(const char* checkpoint)
{
    [TestFlight passCheckpoint:[NSString stringWithUTF8String:checkpoint]];
}
