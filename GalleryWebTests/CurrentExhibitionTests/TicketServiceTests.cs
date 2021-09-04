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
    class TicketServiceTests
    {
        Mapper _mapper;
        Mock<IUnitOfWork> mockUOF;
        ICurrentExhibitionService currExhService;
        ITicketService ticketService;
        #region
        static CurrentExhibitionModel CE = new CurrentExhibitionModel
        {
            Id = 1,
           Exhibition= new ExhibitionModel { Id = 1, Price = 2},
           Tickets = expectedfullList,
           MaxTicketQuantity = 1
        };

        static List<TicketInCartModel> expectedfullList = new List<TicketInCartModel>()
        {
            new TicketInCartModel()
            {
                CartId = "somestring",
                CurExhId = 1,
                CurrentExhibition = CE,

            }
        };

        TicketInCartModel ticket = new TicketInCartModel
        {
            CartId = "somestring",
            CurExhId = 1,
            CurrentExhibition = CE,
        };
        CurrentExhibition CEentity;

        List<TicketsInCart> ticketentities;
        Exhibition e;
        #endregion
        [SetUp]
        public void SetUp()
        {
            _mapper = UnitTestsHelper.CreateMapperProfile();
            e = _mapper.Map<Exhibition>(CE.Exhibition);
            CEentity = _mapper.Map<CurrentExhibition>(CE);

            ticketentities = _mapper.Map<List<TicketsInCart>>(expectedfullList);

            mockUOF = new Mock<IUnitOfWork>();
            mockUOF.Setup(x => x.TicketsInCartRepository.GetAll())
                .Returns(ticketentities);
        
            mockUOF.Setup(x => x.CurrentExhibitionRepository.Get(CEentity.Id))
                .Returns(CEentity);

            ticketService = new TicketService(mockUOF.Object, _mapper);
        }

        [TestCase(null)]//crush
        [TestCase("sing")]//pass
        public void CountTotalAmount_IdCartPassed_TotalAmountReturned(string? cartId)
		{
            //arrange
            var expected = expectedfullList[0].CurrentExhibition.Exhibition.Price;//2

			//act
			var actual = ticketService.CountTotalAmount(cartId);

			//assert
			Assert.AreEqual(expected, actual);
		}

        [Test]
        public void DeleteItem_ItemDeleted_MaxQuantityIncrease()
        {
            //arrange
            var expectedQuantity = CE.MaxTicketQuantity + 1;

            //act
            ticketService.DeleteItem(ticket.Id, CE.Id);

            //assert
            Assert.AreEqual(expectedQuantity, CE.MaxTicketQuantity);
        }

        [Test]
        public void UpdateCartId_NewCartIdPassed_ItemsUpdated()
        {
            //arrange
            var oldId = expectedfullList[0].CartId;
            var newId = "bla";

            //act
            ticketService.UpdateCartId(oldId, newId);

            //assert

            mockUOF.Verify(x => x.TicketsInCartRepository.Update(ticketentities[0]), Times.Once);
            mockUOF.Verify(x => x.Save(), Times.Exactly(ticketentities.Count));
        }
    }
}
