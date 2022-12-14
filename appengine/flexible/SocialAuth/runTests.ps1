# Copyright(c) 2017 Google Inc.
#
# Licensed under the Apache License, Version 2.0 (the "License"); you may not
# use this file except in compliance with the License. You may obtain a copy of
# the License at
#
# http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
# WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
# License for the specific language governing permissions and limitations under
# the License.

Import-Module -DisableNameChecking ..\..\..\BuildTools.psm1

$envars = $env:DataProtection:Bucket, $env:DataProtection:KmsKeyName
try {
    $env:DataProtection:Bucket = $env:GOOGLE_BUCKET
    $env:DataProtection:KmsKeyName = "projects/$env:GOOGLE_PROJECT_ID/locations/global/keyRings/dataprotection/cryptoKeys/masterkey"
    Run-KestrelTest 5601 -CasperJs11
} finally {
    $env:DataProtection:Bucket, $env:DataProtection:KmsKeyName = $envars
}