protocol IVisitor {
    func visit(_ brand: BrandFacet) -> String
    func visit(_ schema: SchemaFacet) -> String
}

struct Visitor: IVisitor {
    func visit(_ brand: BrandFacet) -> String {
        return "BRAND: \(brand.name)"
    }

    func visit(_ schema: SchemaFacet) -> String {
        return "SCHEMA: \(schema.schemaLabel) \(schema.schemaIdentifier)"
    }
}
