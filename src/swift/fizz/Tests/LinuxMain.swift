import XCTest

import fizzTests

var tests = [XCTestCaseEntry]()
tests += fizzTests.allTests()
XCTMain(tests)