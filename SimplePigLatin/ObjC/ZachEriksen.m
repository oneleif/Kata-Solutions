// Kata: https://www.codewars.com/kata/520b9d2ad5c005041100000f
#import <Foundation/Foundation.h>

NSString *pigIt(NSString *s) {
    NSMutableString *str = NSMutableString.new;
    NSArray *words = [s componentsSeparatedByString:@" "];
    int i;
    for (i = 0; i < [words count]; i++) {
        NSString *part = words[i];
        
        NSString *tail = [NSString stringWithFormat:@"%c",[part characterAtIndex:0]];
        [str appendFormat:@"%@%@ay ", [part substringFromIndex:1], tail];
    }
    return [str substringToIndex: str.length - 1];
}