protocol IVisitor {
    func visit(_ brand: BrandFacet) -> String
    func visit(_ schema: SchemaFacet) -> String
}

struct visitor: IVisitor {
    func visit(_ brand: BrandFacet) -> String {
        return "BRAND: \(brand.name)"
    }

    func visit(_ schema: SchemaFacet) -> String {
        return "SCHEMA: \(schema.schemaLabel) \(schema.schemaIdentifier)"
    }
}
