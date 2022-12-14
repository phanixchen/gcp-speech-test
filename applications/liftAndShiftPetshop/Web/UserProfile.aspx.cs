// Copyright (c) 2018 Google LLC.
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not
// use this file except in compliance with the License. You may obtain a copy of
// the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
// WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
// License for the specific language governing permissions and limitations under
// the License.

using System;

namespace PetShop.Web {
	public partial class UserProfile : System.Web.UI.Page {	   

		/// <summary>
		/// Update profile
		/// </summary>
		protected void btnSubmit_Click(object sender, EventArgs e) {
			Profile.AccountInfo = AddressForm.Address;
			Profile.Save();
            lblMessage.Text = "Your profile information has been successfully updated.<br>&nbsp;";
		}

        /// <summary>
        /// Handle Page load event 
        /// </summary>
		protected void Page_Load(object sender, EventArgs e) {
			if(!IsPostBack)
				BindUser();
		}

		/// <summary>
		/// Bind controls to profile
		/// </summary>
		private void BindUser() {
			AddressForm.Address = Profile.AccountInfo;
		}
}
}
