module Leap

let isDivisiableByFour year = year%4=0  
let divisableBy100 year = year%100 = 0

let divisableBy400 year = year%400 = 0

let leapYear (year: int): bool = 
    (isDivisiableByFour year && not (divisableBy100 year))
    || divisableBy400 year