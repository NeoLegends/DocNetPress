﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocNetPress.Documentation
{
    /// <summary>
    /// Contains all the documentation for a specified assembly.
    /// </summary>
    public class Documentation : IEnumerable<DocumentedMember>
    {
        /// <summary>
        /// Gets the assembly's name.
        /// </summary>
        public String AssemblyName { get; private set; }

        /// <summary>
        /// Gets the path to the assembly file.
        /// </summary>
        public String AssemblyPath { get; private set; }

        /// <summary>
        /// Gets all documented members in the assembly.
        /// </summary>
        public IEnumerable<DocumentedMember> Members { get; private set; }

        /// <summary>
        /// Gets the path to the documentation file.
        /// </summary>
        public String DocumentationPath { get; private set; }

        /// <summary>
        /// Gets the amount of stored <see cref="DocumentedMember"/>s.
        /// </summary>
        public int Count
        {
            get
            {
                return this.Members.Count();
            }
        }

        /// <summary>
        /// Initializes a new <see cref="Documentation"/>.
        /// </summary>
        /// <param name="assemblyName">The assembly's name.</param>
        /// <param name="assemblyPath">The path to the assembly file.</param>
        /// <param name="members">All documented members in the assembly.</param>
        /// <param name="documentationPath">The path to the documentation file.</param>
        public Documentation(String assemblyName, String assemblyPath, IEnumerable<DocumentedMember> members, String documentationPath)
        {
            Contract.Requires<ArgumentNullException>(assemblyPath != null && documentationPath != null && assemblyName != null && members != null);

            this.AssemblyName = assemblyName;
            this.AssemblyPath = assemblyPath;
            this.Members = members;
            this.DocumentationPath = documentationPath;
        }

        /// <summary>
        /// Gets the <see cref="IEnumerator{T}"/>.
        /// </summary>
        /// <returns>An <see cref="IEnumerator{T}"/>.</returns>
        public IEnumerator<DocumentedMember> GetEnumerator()
        {
            return this.Members.GetEnumerator();
        }

        /// <summary>
        /// Gets the <see cref="IEnumerator"/>.
        /// </summary>
        /// <returns>An <see cref="IEnumerator"/>.</returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.Members.GetEnumerator();
        }

        /// <summary>
        /// Contains Contract.Invariant definitions.
        /// </summary>
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this.AssemblyName != null);
            Contract.Invariant(this.AssemblyPath != null);
            Contract.Invariant(this.Members != null);
            Contract.Invariant(this.DocumentationPath != null);
        }
    }
}