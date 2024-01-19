﻿using MTCG.Domain;

namespace MTCG.Persistence.Repositories.Cards;

public interface CardRepository
{

    ValueTask<List<Card>> GetUserCardsAsync(int userId);

    ValueTask<List<Element>> GetCardElementsAsync();

}