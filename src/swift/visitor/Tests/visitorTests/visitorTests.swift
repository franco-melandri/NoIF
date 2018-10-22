import XCTest
@testable import visitor

final class visitorTests: XCTestCase {

    let sut = RenderFacets()

    func test_visitOneElement() {
        XCTAssertEqual(sut.render([]), "")
    }

    static var allTests = [
        ("test_visitOneElement", test_visitOneElement),
    ]
}
