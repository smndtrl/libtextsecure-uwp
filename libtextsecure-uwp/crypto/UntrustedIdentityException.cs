/** 
 * Copyright (C) 2015 smndtrl
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using libaxolotl;
using System;

namespace libtextsecure.crypto
{
    public class UntrustedIdentityException : Exception
    {

        public IdentityKey IdentityKey { get; internal set; }
        public string E164Number { get; internal set; }

        public UntrustedIdentityException(string s, string e164Number, IdentityKey identityKey) : base(s)
        {
            this.E164Number = e164Number;
            this.IdentityKey = identityKey;
        }

        public UntrustedIdentityException(UntrustedIdentityException e)
            : this(e.Message, e.E164Number, e.IdentityKey)
        {
        }

    }
}
