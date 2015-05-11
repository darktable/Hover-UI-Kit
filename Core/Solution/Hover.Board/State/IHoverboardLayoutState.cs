using Hover.Board.Items;
using Hover.Common.State;

namespace Hover.Board.State {

	/*================================================================================================*/
	public interface IHoverboardLayoutState {

		IItemLayout ItemLayout { get; }
		IBaseItemState[] Items { get; }
		float DisplayStrength { get; set; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		void PreventEveryItemSelectionViaDisplay(string pName, bool pPrevent);

		/*--------------------------------------------------------------------------------------------*/
		bool IsEveryItemSelectionPreventedViaDisplay();

	}

}
