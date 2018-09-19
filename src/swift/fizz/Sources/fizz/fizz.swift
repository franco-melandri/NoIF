public struct fizz {

    let actions: [ ( (Int) -> Bool, () -> String) ] = [
        ( { number in number % 3 == 0}, { "fizz"} ),
        ( { number in number % 5 == 0}, { "buzz"} ),
        ( { number in number % 7 == 0}, { "pazz"} ),
        ( { number in number % 11 == 0}, { "razz"} ),
    ]

    public func getResult(_ number: Int) -> String {

        return actions
                    .filter { $0.0(number) }
                    .reduce (nil)  { acc, item in 
                            (acc ?? "") + item.1() 
                        } ?? "\(number)"
    }
}
