struct RenderFacets {
    func render(_ facets: [IElement]) -> String {
        let visitor = Visitor()        
        return facets.reduce ("") { acc, item in 
            "\(acc)\(item.accept(visitor))"
        }
    }
}