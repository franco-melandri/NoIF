using NUnit.Framework;
using Visitor;

namespace Tests {
    
    [TestFixture]
    public class FacetTests
    {    
        [Test]
        public void ShouldFillBrandFacet() 
        {
            var sut = new BrandFacet{
                label = "brandLabel"
            };
            Assert.AreEqual(sut.identifier, "Brand");
            Assert.AreEqual(sut.label, "brandLabel");
        }
    
        [Test]
        public void ShouldFillCoulourFacet() 
        {
            var sut = new ColourFacet{
                label = "colourLabel"
            };
            Assert.AreEqual(sut.identifier, "Colour");
            Assert.AreEqual(sut.label, "colourLabel");
        }

        [Test]
        public void ShouldFillSchemaFacet() 
        {
            var sut = new SchemaFacet{
                label = "label",
                schemaLabel = "schemaLabel",
                schemaIdentifier = "schemaIdentifier"
            };
            Assert.AreEqual(sut.identifier, "Schema");
            Assert.AreEqual(sut.label, "label");
            Assert.AreEqual(sut.schemaLabel, "schemaLabel");
            Assert.AreEqual(sut.schemaIdentifier, "schemaIdentifier");
        }

        [Test]
        public void ShouldFillCategoryFacet() 
        {
            var sut = new CategoryFacet{
                label = "label",
            };
            Assert.AreEqual(sut.identifier, "Category");
            Assert.AreEqual(sut.label, "label");
        }
    }    
}