﻿namespace AA.Application.Services.Mapper
{
    public interface IMapper<TSource, TDestination>
    {
        TDestination Map(TSource source);
    }
}
