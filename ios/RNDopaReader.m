
#import "RNDopaReader.h"

@implementation RNDopaReader

- (dispatch_queue_t)methodQueue
{
    return dispatch_get_main_queue();
}
RCT_EXPORT_MODULE()

RCT_EXPORT_METHOD(initCard : (RCTResponseSenderBlock)callback) {
    
    callback(@[[NSNull null], @(true)]);
}

@end
  