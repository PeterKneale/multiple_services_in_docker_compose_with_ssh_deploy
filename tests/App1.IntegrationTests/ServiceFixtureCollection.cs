namespace App1.IntegrationTests;

[CollectionDefinition(nameof(ServiceFixtureCollection))]
public class ServiceFixtureCollection : ICollectionFixture<ServiceFixture>
{
}