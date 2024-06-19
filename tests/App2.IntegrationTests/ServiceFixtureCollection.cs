namespace App2.IntegrationTests;

[CollectionDefinition(nameof(ServiceFixtureCollection))]
public class ServiceFixtureCollection : ICollectionFixture<ServiceFixture>
{
}