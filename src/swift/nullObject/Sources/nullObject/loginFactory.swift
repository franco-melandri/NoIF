public struct LoginFactory {
    
    public enum ServiceType: String {
        case facebook, google
    }

    private let loginServices: [String: () -> LoginService] = [
        ServiceType.facebook.rawValue: { FacebookLogin() },
        ServiceType.google.rawValue: { GoogleLogin() },
    ]

    func getService(ofType type: String) -> LoginService {
        return loginServices[type, default: { NullLogin() }]()
    }

}
