# Domain Models

## Menu

```csharp
class Menu
{
    Menu Create();
    void AddDinner(Dinner dinner);
    void RemoveDinner(Dinner dinner);
    void UpdateSection(MenuSection section);
}
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Menu 1",
    "description": "Menu 1 description",
    "averageRating": 4.5,
    "sections": [
        {
            "id": "00000000-0000-0000-0000-000000000000",
            "name": "Section 1",
            "description": "Section 1 description",
            "items": [
                {
                    "id": "00000000-0000-0000-0000-000000000000",
                    "name": "Item 1",
                    "description": "Item 1 description",
                    "price": 10.99
                },
                {
                    "id": "00000000-0000-0000-0000-000000000000",
                    "name": "Item 2",
                    "description": "Item 2 description",
                    "price": 12.99
                }
            ]
    }],
    "createdDateTime": "2022-01-01T00:00:00Z",
    "updatedDateTime": "2022-01-01T00:00:00Z",
    "hostId": "00000000-0000-0000-0000-000000000000",
    "dinnerIds": ["00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000"],
    "menuReviewIds": ["00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000"]
}
```