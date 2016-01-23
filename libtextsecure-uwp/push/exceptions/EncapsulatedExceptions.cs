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

using libtextsecure.crypto;
using System;
using System.Collections.Generic;

namespace libtextsecure.push.exceptions
{
    internal class EncapsulatedExceptions : Exception
    {

        public IList<UntrustedIdentityException> UntrustedIdentityExceptions { get; internal set; }
        public IList<UnregisteredUserException> UnregisteredUserExceptions { get; internal set; }
        public IList<NetworkFailureException> NetworkExceptions { get; internal set; }

        public EncapsulatedExceptions(IList<UntrustedIdentityException> untrustedIdentities,
                                      IList<UnregisteredUserException> unregisteredUsers,
                                      IList<NetworkFailureException> networkExceptions)
        {
            this.UntrustedIdentityExceptions = untrustedIdentities;
            this.UnregisteredUserExceptions = unregisteredUsers;
            this.NetworkExceptions = networkExceptions;
        }

        public EncapsulatedExceptions(UntrustedIdentityException e)
        {
            this.UntrustedIdentityExceptions = new List<UntrustedIdentityException>();
            this.UnregisteredUserExceptions = new List<UnregisteredUserException>();
            this.NetworkExceptions = new List<NetworkFailureException>();

            this.UntrustedIdentityExceptions.Add(e);
        }
    }
}
