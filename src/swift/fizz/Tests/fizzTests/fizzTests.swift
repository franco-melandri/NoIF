import XCTest
@testable import fizz

// 1,2,fizz,4,buzz,....

final class fizzTests: XCTestCase {

    func testFizzBuzz() {
        let sut = fizz()
        let result = sut.getResult(3)
        XCTAssertEqual(result, "fizz")
    }

    func testFizzBuzzOne() {
        let sut = fizz()
        let result = sut.getResult(1)
        XCTAssertEqual(result, "1")
    }

    func testFizzBuzzFive() {
        let sut = fizz()
        let result = sut.getResult(5)
        XCTAssertEqual(result, "buzz")
    }

    func testFizzBuzzRazz() {
        let sut = fizz()
        let result = sut.getResult(11)
        XCTAssertEqual(result, "razz")
    }

    func testFizzBuzzFour() {
        let sut = fizz()
        let result = sut.getResult(4)
        XCTAssertEqual(result, "4")
    }

    func testFizzBuzzFizzBuzz() {
        let sut = fizz()
        let result = sut.getResult(15)
        XCTAssertEqual(result, "fizzbuzz")
    }

    func testFizzBuzzFizzBuzzRazz() {
        let sut = fizz()
        let result = sut.getResult(15*11)
        XCTAssertEqual(result, "fizzbuzzrazz")
    }

    func testFizzBuzzPazz() {
        let sut = fizz()
        let result = sut.getResult(7)
        XCTAssertEqual(result, "pazz")
    }

    static var allTests = [
        ("testFizzBuzz", testFizzBuzz),
    ]
}
