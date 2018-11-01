import XCTest
@testable import nullObject

final class NullObjectTests: XCTestCase {

    func testFacebookLoginSuccess() {
        let sut = LoginFactory()
        let loginService = sut.getService(ofType: LoginFactory.ServiceType.facebook.rawValue)
        let loginSuccess = loginService.login()
        XCTAssertTrue(loginSuccess)
    }

    func testGoogleLoginSuccess() {
        let sut = LoginFactory()
        let loginService = sut.getService(ofType: LoginFactory.ServiceType.google.rawValue)
        let loginSuccess = loginService.login()
        XCTAssertTrue(loginSuccess)
    }

    func testNullLoginFailure() {
        let sut = LoginFactory()
        let loginService = sut.getService(ofType: "Github")
        let loginSuccess = loginService.login()
        XCTAssertFalse(loginSuccess)
    }

    static var allTests = [
        ("testFacebookLoginSuccess", testFacebookLoginSuccess),
        ("testGoogleLoginSuccess", testGoogleLoginSuccess),
        ("testNullLoginFailure", testNullLoginFailure),
    ]

}
