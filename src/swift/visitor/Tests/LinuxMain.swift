import XCTest

import visitorTests

var tests = [XCTestCaseEntry]()
tests += visitorTests.allTests()
XCTMain(tests)