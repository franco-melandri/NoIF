public struct LoginFactory {
    
    public enum ServiceType: String {
        case facebook, google
    }

    private let loginServices: [String: () -> LoginService] = [
        ServiceType.facebook.rawValue: { FacebookLogin() },
    ]

    func getService(ofType type: ServiceType) -> LoginService {
        return loginServices[type.rawValue]?() ?? NullLogin()
    }

}
