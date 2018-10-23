struct RenderFacets {
    func render(_ facets: [IElement]) -> [String] {
        let visitor = PrintVisitor()        
        return facets.reduce ([]) { acc, item in 
            return acc + item.accept(visitor)
        }
    }

    func filterBrand(_ facets: [IElement]) -> [String] {
        let visitor = FilterBrandVisitor()        
        return facets.reduce ([]) { acc, item in 
            return acc + item.accept(visitor)
        }
    }

    func filterSchema(_ facets: [IElement]) -> [String] {
        let visitor = FilterSchemaVisitor()        
        return facets.reduce ([]) { acc, item in 
            return acc + item.accept(visitor)
        }
    }
}