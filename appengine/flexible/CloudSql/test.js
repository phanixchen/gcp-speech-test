// Copyright(c) 2017 Google Inc.
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

var system = require('system');
var host = system.env['CASPERJS11_URL'];

casper.test.begin('Home page is OK.', 2, function suite(test) {
    casper.start(host + '/', function (response) {
        test.assertEquals(200, response.status);
        test.assertSelectorHasText('H2', 'Visitor Log');
    });

    casper.run(function () {
        test.done();
    });
});