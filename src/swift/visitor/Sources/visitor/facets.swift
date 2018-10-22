enum Facets {
    static let Brand = "Brand"
    static let Schema = "Schema"
}

protocol IElement {
    func accept(visitor: IVisitor) -> String
}

protocol BaseFacet {
    var label: String { get }
    var identifier: String { get }
}

struct BrandFacet: BaseFacet {
    let label: String
    let identifier: String
    let name: String

    init (label: String,
          name: String) {
        self.identifier = Facets.Brand;
        self.label = label
        self.name = name
    }
}

struct SchemaFacet: BaseFacet {
    let label: String
    let identifier: String
    let schemaLabel: String
    let schemaIdentifier: String

    init (label: String,
          schemaLabel: String,
          schemaIdentifier: String) {
        self.identifier = Facets.Schema;
        self.label = label
        self.schemaLabel = schemaLabel
        self.schemaIdentifier = schemaIdentifier
    }
}
