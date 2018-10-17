#import <Foundation/Foundation.h>

NSString *toCamelCase(NSString *s) {
    if ([s length] < 1) {
        return @"";
    }
    
    NSString *replace;
    if ([s containsString:@"_"]) {
        replace = @"_";
    } else if ([s containsString:@"-"]) {
        replace = @"-";
    }

    NSArray *values = [s componentsSeparatedByString: replace];
    NSMutableString *camelCase = NSMutableString.new;
    [camelCase appendFormat:@"%@", values[0]];
    for (int i = 1; i < [values count]; i++) {
        [camelCase appendFormat:@"%@", [values[i] capitalizedString]];
    }
    return camelCase;
}