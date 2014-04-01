using AutoMapper;

namespace TrendsTracker.Web.Utilities
{
    public static class MappingHelper
    {
        public static T ToViewModel<T>(this object entity)
        {
            return (T)Mapper.Map(entity, entity.GetType(), typeof(T));
        }

        /// <summary>
        /// </summary>
        public static TEntity ToEntity<TViewModel, TEntity>(this TViewModel viewModel, TEntity loadedEntity)
        {
            return Mapper.Map<TViewModel, TEntity>(viewModel, loadedEntity);
        }
    }
}