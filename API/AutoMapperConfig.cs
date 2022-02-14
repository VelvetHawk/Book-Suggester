using API.Models.TransferModels;
using API.Models.ViewModels;
using AutoMapper;

namespace API
{
    public static class AutoMapperConfig
    {
        public static void ConfigureMaps()
        {
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<SubjectDto, SubjectViewModel>()
                    .ForMember(destination => destination.SubjectType, options => options.MapFrom(source => source.Subject_Type))
                    .ForMember(destination => destination.WorkCount, options => options.MapFrom(source => source.Work_Count))
                    .ForMember(destination => destination.EBookCount, options => options.MapFrom(source => source.EBook_Count));

                config.CreateMap<WorkDto, WorkViewModel>()
                    .ForMember(destination => destination.EditionCount, options => options.MapFrom(source => source.Edition_Count))
                    .ForMember(destination => destination.CoverId, options => options.MapFrom(source => source.Cover_Id))
                    .ForMember(destination => destination.CoverEditionKey, options => options.MapFrom(source => source.Cover_Edition_Key))
                    .ForMember(destination => destination.IaCollection, options => options.MapFrom(source => source.Ia_Collection))
                    .ForMember(destination => destination.LendingEdition, options => options.MapFrom(source => source.Lending_Edition))
                    .ForMember(destination => destination.FirstPublishYear, options => options.MapFrom(source => source.First_Publish_Year))
                    .ForMember(destination => destination.PublicScan, options => options.MapFrom(source => source.Public_Scan))
                    .ForMember(destination => destination.HasFullText, options => options.MapFrom(source => source.Has_Fulltext));

                config.CreateMap<AvailabilityDto, AvailabilityViewModel>()
                    .ForMember(destination => destination.AvailableToBrowse, options => options.MapFrom(source => source.Available_To_Browse))
                    .ForMember(destination => destination.AvailableToBorrow, options => options.MapFrom(source => source.Available_To_Borrow))
                    .ForMember(destination => destination.AvailableToWaitlist, options => options.MapFrom(source => source.Available_To_Waitlist))
                    .ForMember(destination => destination.IsPrintDisabled, options => options.MapFrom(source => source.Is_PrintDisabled))
                    .ForMember(destination => destination.IsReadable, options => options.MapFrom(source => source.Is_Readable))
                    .ForMember(destination => destination.IsLendable, options => options.MapFrom(source => source.Is_Lendable))
                    .ForMember(destination => destination.IsPreviewable, options => options.MapFrom(source => source.Is_Previewable))
                    .ForMember(destination => destination.OpenLibraryWork, options => options.MapFrom(source => source.OpenLibrary_Work))
                    .ForMember(destination => destination.OpenLibraryEdition, options => options.MapFrom(source => source.OpenLibrary_Edition))
                    .ForMember(destination => destination.IsRestricted, options => options.MapFrom(source => source.Is_Restricted))
                    .ForMember(destination => destination.IsBrowseable, options => options.MapFrom(source => source.Is_Browseable));

                config.CreateMap<AuthorDto, AuthorViewModel>();
            });

            mapperConfig.CompileMappings();
        }
    }
}
