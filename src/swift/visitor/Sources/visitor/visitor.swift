protocol IVisitor {
    func visit(_ brand: BrandFacet) -> [String]
    func visit(_ schema: SchemaFacet) -> [String]
}

struct PrintVisitor: IVisitor {
    func visit(_ brand: BrandFacet) -> [String] {
        return ["BRAND: \(brand.name)"]
    }

    func visit(_ schema: SchemaFacet) -> [String] {
        return ["SCHEMA: \(schema.schemaLabel) \(schema.schemaIdentifier)"]
    }
}

struct FilterBrandVisitor: IVisitor {
    func visit(_ brand: BrandFacet) -> [String] {
        return ["BRAND: \(brand.name)"]
    }

    func visit(_ schema: SchemaFacet) -> [String] {
        return []
    }
}

struct FilterSchemaVisitor: IVisitor {
    func visit(_ brand: BrandFacet) -> [String] {
        return []
    }

    func visit(_ schema: SchemaFacet) -> [String] {
        return ["SCHEMA: \(schema.schemaLabel) \(schema.schemaIdentifier)"]
    }
}
