import XCTest
@testable import visitor

final class visitorTests: XCTestCase {

    let sut = RenderFacets()

    func test_visitOneBrandElement() {
        let brand = BrandFacet(label: "label",
                               name: "ARMANI")
        XCTAssertEqual(sut.render([brand]), ["BRAND: ARMANI"])
    }

    func test_visitOneSchemaElement() {
        let schema = SchemaFacet(label: "label",
                                 schemaLabel: "SCHEMA_LBL_1",
                                 schemaIdentifier: "SCHEMA_ID_1")
        XCTAssertEqual(sut.render([schema]), ["SCHEMA: SCHEMA_LBL_1 SCHEMA_ID_1"])
    }

    func test_visitOneBrandAndOneSchemaElement() {
        let brand = BrandFacet(label: "label",
                               name: "ARMANI")
        let schema = SchemaFacet(label: "label",
                                 schemaLabel: "SCHEMA_LBL_1",
                                 schemaIdentifier: "SCHEMA_ID_1")
        XCTAssertEqual(sut.render([brand, schema]), 
                                  ["BRAND: ARMANI",
                                   "SCHEMA: SCHEMA_LBL_1 SCHEMA_ID_1"])
    }

    func test_visitMultipleBrandAndMultipleSchemaElement() {
        let brand = BrandFacet(label: "label",
                               name: "ARMANI")
        let schema = SchemaFacet(label: "label",
                                 schemaLabel: "SCHEMA_LBL_1",
                                 schemaIdentifier: "SCHEMA_ID_1")
        let brandSecond = BrandFacet(label: "label",
                                     name: "MONCLER")
        let brandThird = BrandFacet(label: "label",
                                    name: "OTTO")
        let schemaSecond = SchemaFacet(label: "label",
                                       schemaLabel: "SCHEMA_LBL_2",
                                       schemaIdentifier: "SCHEMA_ID_2")
        XCTAssertEqual(sut.render([brand, schema, brandSecond, brandThird, schemaSecond]), 
                                  ["BRAND: ARMANI",
                                   "SCHEMA: SCHEMA_LBL_1 SCHEMA_ID_1",
                                   "BRAND: MONCLER",
                                   "BRAND: OTTO",
                                   "SCHEMA: SCHEMA_LBL_2 SCHEMA_ID_2"])
    }

    func test_filterBrandFromElements() {
        let brand = BrandFacet(label: "label",
                               name: "ARMANI")
        let schema = SchemaFacet(label: "label",
                                 schemaLabel: "SCHEMA_LBL_1",
                                 schemaIdentifier: "SCHEMA_ID_1")
        let brandSecond = BrandFacet(label: "label",
                                     name: "MONCLER")
        let brandThird = BrandFacet(label: "label",
                                    name: "OTTO")
        let schemaSecond = SchemaFacet(label: "label",
                                       schemaLabel: "SCHEMA_LBL_2",
                                       schemaIdentifier: "SCHEMA_ID_2")
        XCTAssertEqual(sut.filterBrand([brand, schema, brandSecond, brandThird, schemaSecond]), 
                                       ["BRAND: ARMANI",
                                        "BRAND: MONCLER",
                                        "BRAND: OTTO"])
    }

    func test_filterSchemaFromElements() {
        let brand = BrandFacet(label: "label",
                               name: "ARMANI")
        let schema = SchemaFacet(label: "label",
                                 schemaLabel: "SCHEMA_LBL_1",
                                 schemaIdentifier: "SCHEMA_ID_1")
        let brandSecond = BrandFacet(label: "label",
                                     name: "MONCLER")
        let brandThird = BrandFacet(label: "label",
                                    name: "OTTO")
        let schemaSecond = SchemaFacet(label: "label",
                                       schemaLabel: "SCHEMA_LBL_2",
                                       schemaIdentifier: "SCHEMA_ID_2")
        XCTAssertEqual(sut.filterSchema([brand, schema, brandSecond, brandThird, schemaSecond]), 
                                        ["SCHEMA: SCHEMA_LBL_1 SCHEMA_ID_1",
                                         "SCHEMA: SCHEMA_LBL_2 SCHEMA_ID_2"])
    }

    static var allTests = [
        ("test_visitOneBrandElement", test_visitOneBrandElement),
    ]
}
