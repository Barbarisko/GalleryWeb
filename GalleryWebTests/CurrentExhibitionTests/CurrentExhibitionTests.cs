using AutoMapper;
using GalleryBLL.Interfaces;
using GalleryBLL.Models;
using GalleryBLL.Services;
using GalleryDAL.Entities;
using GalleryDAL.UnitOfWork;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalleryWebTests.CurrentExhibitionTests
{
    [TestFixture]
    class CurrentExhibitionTests
    {
        Mapper _mapper;
        Mock<IUnitOfWork> mockUOF;
        ICurrentExhibitionService currExhService;

        static PictureModel pic = new PictureModel
        {
            Price = 2
        };
        static List<ExhibitedPictureModel> expectedfullList = new List<ExhibitedPictureModel>()
        {
            new ExhibitedPictureModel()
            {
                IdCurrExh=1,
                IdPicture=1, 
                Picture = pic, 
                Room=2
            }
        };
        List<ExhibitedPicture> pictureEntities;

        static CurrentExhibitionModel CE = new CurrentExhibitionModel
        {
            Id=1,
            ExhibitedPictures = expectedfullList
        };
        CurrentExhibition CEentity;

        [SetUp]
        public void SetUp()
        {
            _mapper = UnitTestsHelper.CreateMapperProfile();
            pictureEntities = _mapper.Map<List<ExhibitedPicture>>(expectedfullList);

            mockUOF = new Mock<IUnitOfWork>();
            mockUOF.Setup(r => r.ExhibitedPictureRepository.GetAll())
                .Returns(pictureEntities);
            mockUOF.Setup(r => r.CurrentExhibitionRepository.Get(CE.Id)).Returns(CEentity);
            
            currExhService = new CurrentExhibitionService(mockUOF.Object, _mapper);
        }

        [TestCase(1)]
        public void CountEstimatedPrice_CurExhIdPassed_PriceCounted(int ceId)
        {
            int expected = 0;
            //arrange
            foreach(ExhibitedPictureModel p in expectedfullList)
            {
                expected += p.Picture.Price;//2
            }

            //act
            currExhService.CountEstimatePrice(ceId);
            var actual = mockUOF.Object.CurrentExhibitionRepository.Get(ceId).EstimatedPrice;

            //assert
            Assert.AreEqual(expected, actual);
        }


    }
}
